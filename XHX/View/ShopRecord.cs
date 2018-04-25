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
    public partial class ShopRecord: BaseForm
    {
        #region Field
        XtraGridDataHandler<ShopRecordDto> dataHandler = null;
        localhost.Service webService = new localhost.Service();
        MSExcelUtil msExcelUtil = new MSExcelUtil();
        //LocalService webService = new LocalService();
        #endregion
        public ShopRecord()
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
            grcShop.DataSource = new List<ShopRecordDto>();
            dataHandler = new XtraGridDataHandler<ShopRecordDto>(grvShop);
            CommonHandler.SetRowNumberIndicator(grvShop);

            //bind 项目
            XHX.Common.BindComBox.BindProject(cboProject);
        }
        private void SearchResult()
        {
            string prjectCode = CommonHandler.GetComboBoxSelectedValue(cboProject).ToString();
            string shopCode = btnShopCode.Text;
            List<ShopRecordDto> list = new List<ShopRecordDto>();
            DataSet ds = webService.SearchShopRecordUrlList(prjectCode, shopCode);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ShopRecordDto exam = new ShopRecordDto();
                    exam.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    exam.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    exam.ShopName = Convert.ToString(ds.Tables[0].Rows[i]["ShopName"]);
                    exam.RecordUrl = Convert.ToString(ds.Tables[0].Rows[i]["RecordUrl"]);
                    exam.Password = Convert.ToString(ds.Tables[0].Rows[i]["Password"]);
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
                    foreach (ShopRecordDto shop in dataHandler.DataList)
                    {
                        webService.SaveShopRecordUrl(CommonHandler.GetComboBoxSelectedValue(cboProject).ToString(), shop.ShopCode,shop.RecordUrl,shop.Password, UserInfoDto.UserID);
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
           // list.Add(ButtonType.SaveButton);
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
            Worksheet worksheet_FengMian = workbook.Worksheets["录音地址"] as Worksheet;
            string projectCode = CommonHandler.GetComboBoxSelectedValue(cboProject).ToString();
            for (int i = 2; i < 10000; i++)
            {
                string shopCode = msExcelUtil.GetCellValue(worksheet_FengMian, 1, i).ToString();
                if (string.IsNullOrEmpty(shopCode)) break;
                if (!string.IsNullOrEmpty(shopCode))
                {
                    string url =  msExcelUtil.GetCellValue(worksheet_FengMian, 2, i).ToString();
                    string password = msExcelUtil.GetCellValue(worksheet_FengMian, 3, i).ToString();
                    webService.SaveShopRecordUrl(projectCode, shopCode, url, password, UserInfoDto.UserID);
                }
            }
            SearchResult();
            CommonHandler.ShowMessage(MessageType.Information, "上传完毕");
        }

    }
}