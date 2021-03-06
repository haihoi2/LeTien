﻿using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LeTien.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.List
{
    public partial class FrmGTriDLChamCongTheoCa : FormBase
    {
        public FrmGTriDLChamCongTheoCa()
        {
            InitializeComponent();
        }

         private string _id = string.Empty;

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                _id = grvUCList.GetRowCellValue(e.RowHandle, "Oid").ToString();   
            }                  
        }    
     

        #region "Override FromBase"
        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                GiaTriDuLieuChamCongTheoCa br = uow.FindObject<GiaTriDuLieuChamCongTheoCa>(CriteriaOperator.Parse("Oid = ?", _id));
                if (br != null)
                {
                    br.Delete();
                    uow.CommitChanges();
                    uow.PurgeDeletedObjects();
                    RefreshData();
                }
            }
        }
        protected override void OnReload()
        {
            UOW.ReloadChangedObjects();
            xpcGTDLChamCongTheoCa.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách giá trị dữ liệu chấm công theo ca";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách giá trị dữ liệu chấm công theo ca";
            base.OnExportXls();
        }

        #endregion

      


        public void RefreshData()
        {
            OnReload();
        }

        private void grvUCList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.Column.FieldName == "GiaTri")
            {
                if (gv.GetRowCellValue(e.RowHandle, gv.Columns["LoaiDLChamCong!"]) != null)
                {
                    var l = gv.GetRowCellValue(e.RowHandle, grvUCList.Columns["LoaiDLChamCong!"]);
                    XPCollection xpc = new XPCollection(xpcLoaiDLChamCong, CriteriaOperator.Parse("KieuDuLieu = ?",(l as LoaiDuLieuChamCong).KieuDuLieu));
                    if(xpc.Count > 0)
                    {
                        switch ((xpc[0] as LoaiDuLieuChamCong).KieuDuLieu)
                        {
                            case "Int":
                                e.RepositoryItem = spinEdit;
                                break;
                            case "DateTime":
                                e.RepositoryItem = repositoryItemTimeEdit1;
                                break;
                            case "String":
                                e.RepositoryItem = textEdit;
                                break;
                        }
                    }
                   


                }
            }


        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnPreview();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls();           
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }     
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvUCList.OptionsBehavior.ReadOnly)
            {
                btnEdit.Caption = "Đang ở chế độ chỉnh sửa";
                grvUCList.OptionsBehavior.ReadOnly = false;
                grvUCList.OptionsBehavior.Editable = true;
            }
            else
            {
                grvUCList.OptionsBehavior.Editable = false;
                grvUCList.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "Đang ở Chế độ chỉ đọc";
            }
        }
    }
}
