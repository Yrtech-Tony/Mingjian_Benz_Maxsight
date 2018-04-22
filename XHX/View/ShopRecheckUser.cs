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
    public partial class ShopRecheckUser: BaseForm
    {
        #region Field
        XtraGridDataHandler<ShopRecheckUserDto> dataHandler = null;
        localhost.Service webService = new localhost.Service();
        MSExcelUtil msExcelUtil = new MSExcelUtil();
        //LocalService webService = new LocalService();
        #endregion
        public ShopRecheckUser()
        {
            InitializeComponent();
            OnLoadView();
        }
        #region Private Method
        /// <summary>
        /// 进入页面初始化数据
        /// </summary>
        private void OnLoadView()
        {
            grcShop.DataSource = new List<ShopRecheckUserDto>();
            dataHandler = new XtraGridDataHandler<ShopRecheckUserDto>(grvShop);

            //bind 项目
            XHX.Common.BindComBox.BindProject(cboProject);
        }
        private void SearchResult()
        {
            string prjectCode = CommonHandler.GetComboBoxSelectedValue(cboProject).ToString();
            string shopCode = btnShopCode.Text;
            List<ShopRecheckUserDto> list = new List<ShopRecheckUserDto>();
            DataSet ds = webService.ShopRecheckUserSearch(prjectCode, shopCode);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ShopRecheckUserDto exam = new ShopRecheckUserDto();
                    exam.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    exam.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    exam.ShopName = Convert.ToString(ds.Tables[0].Rows[i]["ShopName"]);
                    exam.RecheckUserId = Convert.ToString(ds.Tables[0].Rows[i]["RecheckUserId"]);
                    exam.RecheckUserName = Convert.ToString(ds.Tables[0].Rows[i]["RecheckUserName"]);
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
            Shop_Popup pop = new Shop_Popup("", "", false, "", UserInfoDto.UserID, "");
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
                    foreach (ShopRecheckUserDto shop in dataHandler.DataList)
                    {
                        webService.ShopRecheckUserSave(CommonHandler.GetComboBoxSelectedValue(cboProject).ToString(),shop.ShopCode,shop.RecheckUserId,UserInfoDto.UserID);
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
            list.Add(ButtonType.SaveButton);
            list.Add(ButtonType.ExcelDownButton);
            return list;
        }
        public override void InitButtonClick()
        {
            OnLoadView();

        }
        public override void ExcelDownButtonClick()
        {
            CommonHandler.ExcelExport(grvShop);
        }
        #endregion

    }
}