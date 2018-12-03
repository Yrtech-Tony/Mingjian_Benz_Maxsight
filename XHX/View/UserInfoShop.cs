using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XHX.DTO;
using XHX.Common;
using Microsoft.Office.Interop.Excel;

namespace XHX.View
{
    public partial class UserInfoShop : BaseForm
    {
        #region Field
        XtraGridDataHandler<UserInfoShopDto> dataHandler = null;
        localhost.Service webService = new localhost.Service();
        MSExcelUtil msExcelUtil = new MSExcelUtil();
        GridCheckMarksSelection selection;
        internal GridCheckMarksSelection Selection
        {
            get
            {
                return selection;
            }
        }

        //LocalService webService = new LocalService();
        #endregion
        public UserInfoShop()
        {
            InitializeComponent();
            webService.Url = "http://47.93.118.1/BenzReportServer/service.asmx";
            OnLoadView();
        }
        #region Private Method
        /// <summary>
        /// 进入页面初始化数据
        /// </summary>
        private void OnLoadView()
        {
            grcShop.DataSource = new List<UserInfoShopDto>();
            dataHandler = new XtraGridDataHandler<UserInfoShopDto>(grvShop);
            CommonHandler.SetRowNumberIndicator(grvShop);
            selection = new GridCheckMarksSelection(grvShop);
            selection.CheckMarkColumn.VisibleIndex = 0;
            //bind 项目
            XHX.Common.BindComBox.BindProject(cboProject);
        }
        private void BindUserCombox()
        {
            string prjectCode = CommonHandler.GetComboBoxSelectedValue(cboProject).ToString();
            List<UserInfoDto> list = new List<UserInfoDto>();
            DataSet ds = webService.SearchUserInfoAll(prjectCode);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string areaCode = Convert.ToString(ds.Tables[0].Rows[i]["AreaCode"]);
                    string userId = Convert.ToString(ds.Tables[0].Rows[i]["UserId"]);
                    string[] userIdList = userId.Split(';');
                    foreach (string str in userIdList)
                    {
                        if (!string.IsNullOrEmpty(str))
                        {
                            UserInfoDto exam = new UserInfoDto();
                            exam.UserID = str;
                            exam.UserName = str + "(" + areaCode + ")";
                            if (!list.Contains(exam))
                            {
                                list.Add(exam);
                            }
                        }
                    }

                }
            }
            CommonHandler.SetComboBoxEditItems(cboUserId, list, "UserName", "UserID");
        }
        private void SearchResult()
        {

            string prjectCode = CommonHandler.GetComboBoxSelectedValue(cboProject).ToString();
            string shopCode = btnShopCode.Text;
            List<UserInfoShopDto> list = new List<UserInfoShopDto>();
            DataSet ds = webService.SearchUserInfoShopList(prjectCode, shopCode, CommonHandler.GetComboBoxSelectedValue(cboUserId).ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    UserInfoShopDto exam = new UserInfoShopDto();
                    exam.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    exam.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    exam.ShopName = Convert.ToString(ds.Tables[0].Rows[i]["ShopName"]);
                    exam.UserId = Convert.ToString(ds.Tables[0].Rows[i]["UserId"]);
                    exam.InUserId = Convert.ToString(ds.Tables[0].Rows[i]["InUserId"]);
                    if (ds.Tables[0].Rows[i]["InDateTime"] != DBNull.Value)
                    {
                        exam.InDateTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["InDateTime"]);
                    }
                    else
                    {
                        exam.InDateTime = null;
                    }
                    list.Add(exam);
                }
            }
            grcShop.DataSource = list;
        }
        #endregion
        #region Event
        /// <summary>
        /// 经销商按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShopCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Shop_Popup pop = new Shop_Popup("", "", false, "", UserInfoDto, "");
            pop.ShowDialog();
            ShopDto dto = pop.Shopdto;
            if (dto != null)
            {
                btnShopCode.Text = dto.ShopCode;
                txtShopName.Text = dto.ShopName;
            }
        }
        #endregion
        #region Override Method

        public override void SearchButtonClick()
        {
            SearchResult();
        }
        public override void SaveButtonClick()
        {
            try
            {
                grvShop.CloseEditor();
                if (dataHandler.DataList.Count > 0)
                {
                    foreach (UserInfoShopDto shop in dataHandler.DataList)
                    {
                        webService.SaveUserInfoShop(CommonHandler.GetComboBoxSelectedValue(cboProject).ToString(), shop.UserId, shop.ShopCode, UserInfoDto.UserID,shop.StatusType);
                    }
                }
                CommonHandler.ShowMessage(MessageType.Information, "保存完毕");
            }
            catch (Exception e)
            {
                CommonHandler.ShowMessage(e);
            }
            SearchResult();
        }
        public override List<BaseForm.ButtonType> CreateButton()
        {
            List<ButtonType> list = new List<ButtonType>();
            list.Add(ButtonType.InitButton);
            list.Add(ButtonType.SearchButton);
            list.Add(ButtonType.DeleteRowButton);
            list.Add(ButtonType.SaveButton);
            list.Add(ButtonType.ExcelDownButton);
            return list;
        }
        public override void InitButtonClick()
        {
            OnLoadView();

        }
        public override void DeleteRowButtonClick()
        {
            dataHandler.DelCheckedRow(selection.CheckMarkColumn);
            selection.ClearSelection();
        }   
        public override void ExcelDownButtonClick()
        {
            CommonHandler.ExcelExport(grvShop);
        }
        #endregion

        private void btnModule_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Excel(*.xlsx)|";
            ofp.FilterIndex = 2;
            if (ofp.ShowDialog() == DialogResult.OK)
            {
                btnModule.Text = ofp.FileName;
            }
        }

        private void btnCharterSale_Click(object sender, EventArgs e)
        {
            Workbook workbook = msExcelUtil.OpenExcelByMSExcel(btnModule.Text);
            Worksheet worksheet_FengMian = workbook.Worksheets["经销商"] as Worksheet;
            string projectCode = CommonHandler.GetComboBoxSelectedValue(cboProject).ToString();
            for (int i = 2; i < 10000; i++)
            {
                string userId = msExcelUtil.GetCellValue(worksheet_FengMian, 1, i).ToString();
                if (string.IsNullOrEmpty(userId)) break;
                if (!string.IsNullOrEmpty(userId))
                {
                    string shopCode = msExcelUtil.GetCellValue(worksheet_FengMian, 2, i).ToString();
                    webService.SaveUserInfoShop(projectCode,userId,shopCode,UserInfoDto.UserID,StatusTypes.INSERT);
                }
            }
            SearchResult();
            CommonHandler.ShowMessage(MessageType.Information, "上传完毕");
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindUserCombox();
        }

    }
}