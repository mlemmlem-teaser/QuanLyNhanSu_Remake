
using System;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QuanLyNhanSu.GUI
{
    public static class ExcelHelper
    {
        public static void XuatExcel(
            DataGridView dgv,
            string tenBaoCao)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Không có dữ liệu để xuất Excel!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                save.FileName = tenBaoCao + ".xlsx";

                if (save.ShowDialog() != DialogResult.OK)
                    return;

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("BaoCao");

                    int soCot = dgv.Columns.Count;

                    worksheet.Cell(1, 1).Value = tenBaoCao;

                    worksheet.Range(1, 1, 1, soCot).Merge();

                    worksheet.Cell(1, 1).Style.Font.Bold = true;
                    worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                    worksheet.Cell(1, 1).Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Center;

                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if (!dgv.Columns[i].Visible)
                            continue;

                        int cot = i + 1;

                        worksheet.Cell(3, cot).Value =
                            dgv.Columns[i].HeaderText;

                        worksheet.Cell(3, cot).Style.Font.Bold = true;
                        worksheet.Cell(3, cot).Style.Fill.BackgroundColor =
                            XLColor.LightBlue;

                        worksheet.Cell(3, cot).Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center;
                    }

                    int dongExcel = 4;

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            if (!dgv.Columns[i].Visible)
                                continue;

                            worksheet.Cell(dongExcel, i + 1).Value =
                                Convert.ToString(row.Cells[i].Value) ?? "";
                        }

                        dongExcel++;
                    }

                    worksheet.Range(
                        3, 1, Math.Max(3, dongExcel - 1), soCot
                    ).Style.Border.OutsideBorder =
                        XLBorderStyleValues.Thin;

                    worksheet.Columns().AdjustToContents();
                    worksheet.SheetView.FreezeRows(3);

                    workbook.SaveAs(save.FileName);
                }

                MessageBox.Show(
                    "Xuất Excel thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi xuất Excel: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
