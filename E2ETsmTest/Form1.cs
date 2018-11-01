using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using ZCHRIT.RD.Crypto;

namespace E2ETsmTest
{
    public partial class TsmTest : Form
    {
        private static System.Windows.Forms.TextBox staticProcLogText = null;

        public static void logPrintf(string i_strLog)
        {
            if (staticProcLogText != null)
            {
                staticProcLogText.Text += i_strLog;

                staticProcLogText.SelectionStart = staticProcLogText.TextLength;
                staticProcLogText.ScrollToCaret();
            }
        }

        IniFile m_objIF = new IniFile("./Config.ini");

        public TsmTest()
        {
            InitializeComponent();

            staticProcLogText = ProcLogText;
        }

        private void SeAgentMng_Click(object sender, EventArgs e)
        {
            
        }

        private void TsmTest_Load(object sender, EventArgs e)
        {
            string strSeTsmUrl = m_objIF.IniReadValue("SeAgentMng", "SeTsmUrl");
            string strPartnerId = m_objIF.IniReadValue("SeAgentMng", "PartnerId");
            string strRsaPubkExp = m_objIF.IniReadValue("SeAgentMng", "RsaPubkExp");
            string strRsaPrvtExp = m_objIF.IniReadValue("SeAgentMng", "RsaPrvtExp");
            string strRsaModules = m_objIF.IniReadValue("SeAgentMng", "RsaModules");

            string strEncKey = m_objIF.IniReadValue("SeAgentMng", "SeTsmEncKey");
            string strMacKey = m_objIF.IniReadValue("SeAgentMng", "SeTsmMacKey");
            string strDateTime = m_objIF.IniReadValue("SeAgentMng", "SeTsmDateTime");
            string strTimeStamp = m_objIF.IniReadValue("SeAgentMng", "SeTsmTimeStamp");
            string strReqSeq = m_objIF.IniReadValue("SeAgentMng", "SeTsmReqSeq");
            string strRspSeq = m_objIF.IniReadValue("SeAgentMng", "SeTsmRspSeq");

            this.SeTsmUrl.Text = strSeTsmUrl;
            this.PartnerId.Text = strPartnerId;
            this.RsaPubkExp.Text = strRsaPubkExp;
            this.RsaPrvtExp.Text = strRsaPrvtExp;
            this.RsaModules.Text = strRsaModules;

            this.EncKey.Text = strEncKey;
            this.MacKey.Text = strMacKey;
            this.InitDateTime.Text = strDateTime;
            this.InitTimeStamp.Text = strTimeStamp;
            this.InitComReqSeq.Text = strReqSeq;
            this.InitComRspSeq.Text = strRspSeq;

            GlobalData.strSeiTsmEncKey = strEncKey;
            GlobalData.strSeiTsmMacKey = strMacKey;

            if (strSeTsmUrl.Length > 0)
            {
                Constant.strSeiTsmUrl = strSeTsmUrl;
            }
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            string strSeTsmUrl = this.SeTsmUrl.Text;
            string strPartnerId = this.PartnerId.Text;
            string strRsaPubkExp = this.RsaPubkExp.Text;
            string strRsaPrvtExp = this.RsaPrvtExp.Text;
            string strRsaModules = this.RsaModules.Text;

            if (strSeTsmUrl.Length <= 0)
            {
                MessageBox.Show("SE TSM URL不能为空", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            if (strPartnerId.Length != 8)
            {
                MessageBox.Show("合作方ID长度必须为8", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            if (strRsaPubkExp.Length % 2 != 0)
            {
                MessageBox.Show("RSA公钥指数长度不正确", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            if (strRsaPrvtExp.Length % 2 != 0)
            {
                MessageBox.Show("RSA私钥指数长度不正确", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            if (strRsaModules.Length % 2 != 0)
            {
                MessageBox.Show("RSA模长度不正确", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            m_objIF.IniWriteValue("SeAgentMng", "SeTsmUrl", strSeTsmUrl);
            m_objIF.IniWriteValue("SeAgentMng", "PartnerId", strPartnerId);
            m_objIF.IniWriteValue("SeAgentMng", "RsaPubkExp", strRsaPubkExp);
            m_objIF.IniWriteValue("SeAgentMng", "RsaPrvtExp", strRsaPrvtExp);
            m_objIF.IniWriteValue("SeAgentMng", "RsaModules", strRsaModules);

            MessageBox.Show("保存成功", "保存合作方信息", MessageBoxButtons.OK);
        }

        private void btnInitCommune_Click(object sender, EventArgs e)
        {
            logPrintf("\r\n<<<<<<<<<<<<<<<<<<<<<<<<<< 初始化通讯 >>>>>>>>>>>>>>>>>>>>>>>>>>>\r\n");

            string strSeTsmUrl = this.SeTsmUrl.Text;
            string strPartnerId = this.PartnerId.Text;
            string strRsaPubkExp = this.RsaPubkExp.Text;
            string strRsaPrvtExp = this.RsaPrvtExp.Text;
            string strRsaModules = this.RsaModules.Text;

            if (strPartnerId.Length != 8)
            {
                MessageBox.Show("合作方ID长度必须为8", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            if (strRsaPubkExp.Length % 2 != 0)
            {
                MessageBox.Show("RSA公钥指数长度不正确", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            if (strRsaPrvtExp.Length % 2 != 0)
            {
                MessageBox.Show("RSA私钥指数长度不正确", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            if (strRsaModules.Length % 2 != 0)
            {
                MessageBox.Show("RSA模长度不正确", "保存合作方信息", MessageBoxButtons.OK);
                return;
            }

            Constant.strSeiTsmUrl = strSeTsmUrl;

            string strTimeStamp = MyUtil.getTimeStamp();
            string strReqProcSeq = strTimeStamp + "001" + strPartnerId +  MyUtil.getRnd(12,10);

            JsonUtil objJUHead = new JsonUtil();
            JsonUtil objJUBody = new JsonUtil();
            JsonUtil objJUSign = new JsonUtil();

            objJUHead.addFiled("interfaceVersion", "1.0");
            objJUHead.addFiled("timeStamp", strTimeStamp);
            objJUHead.addFiled("interfaceName", "initCommune");
            objJUHead.addFiled("institutionID", strPartnerId);
            objJUHead.addFiled("reqProcSeq", strReqProcSeq);
            objJUHead.addFiled("order", "00");

            string strSignValue = MyUtil.sign(strRsaPrvtExp,strRsaModules, objJUHead.getJsonData(), objJUBody.getJsonData());

            objJUSign.addFiled("type", "rsa");
            objJUSign.addFiled("signed", strSignValue);

            string strHead = objJUHead.packJsonString("header");
            string strBody = objJUBody.packJsonString("body");
            string strSign = objJUSign.packJsonString("sign");

            string strReqMsg = MyUtil.packMsg(strHead, strBody, strSign);

            string url = Constant.strSeiTsmUrl;
            Encoding encoding = Encoding.GetEncoding("utf-8");
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("reqmsg", strReqMsg);

            string strRspData = HttpUtil.CreatePostHttpResponse(url, parameters, encoding);

            if (strRspData != null ? strRspData == "" : true)
            {
                return;
            }

            JsonUtil[] aobjJU = new JsonUtil[3];
            aobjJU[0] = new JsonUtil();
            aobjJU[1] = new JsonUtil();
            aobjJU[2] = new JsonUtil();

            if (MyUtil.parseRspMsg(strRsaPrvtExp,strRsaModules,strRspData, ref aobjJU) != 0)
            {
                logPrintf("解析响应报文失败\r\n");
                return;
            }

            string strRslt = aobjJU[1].getFiled("excuteRslt");
            string strRsltMsg = aobjJU[1].getFiled("excuteRsltMsg");
            string strSysRnd = aobjJU[1].getFiled("sysRnd");
            string strRspSeq = aobjJU[0].getFiled("rspProcSeq");
            string strOrder = aobjJU[0].getFiled("order");

            strOrder = string.Format("{0:X2}", (int.Parse(strOrder,System.Globalization.NumberStyles.HexNumber) + 1));

            if (!strRslt.Equals("0000"))
            {
                logPrintf("处理失败(" + strRsltMsg + ")\r\n");
                return;
            }

            String strRndCrypto = Crypto.rsaOperator(strRsaPrvtExp, strRsaModules, strSysRnd);

            strTimeStamp = MyUtil.getTimeStamp();
            objJUHead.deleteFiled("timeStamp");
            objJUHead.deleteFiled("rspProcSeq");
            objJUHead.deleteFiled("order");
            objJUBody.deleteFiled("auth");
            objJUHead.addFiled("timeStamp", strTimeStamp);
            objJUHead.addFiled("rspProcSeq", strRspSeq);
            objJUHead.addFiled("order", strOrder);
            objJUBody.addFiled("auth",strRndCrypto);

            strSignValue = MyUtil.sign(strRsaPrvtExp, strRsaModules, objJUHead.getJsonData(), objJUBody.getJsonData());

            objJUSign.deleteFiled("type");
            objJUSign.deleteFiled("signed");
            objJUSign.addFiled("type", "rsa");
            objJUSign.addFiled("signed", strSignValue);

            strHead = objJUHead.packJsonString("header");
            strBody = objJUBody.packJsonString("body");
            strSign = objJUSign.packJsonString("sign");

            strReqMsg = MyUtil.packMsg(strHead, strBody, strSign);

            parameters.Remove("reqmsg");
            parameters.Add("reqmsg", strReqMsg);

            strRspData = HttpUtil.CreatePostHttpResponse(url, parameters, encoding);

            if (strRspData != null ? strRspData == "" : true)
            {
                return;
            }

            aobjJU = new JsonUtil[3];
            aobjJU[0] = new JsonUtil();
            aobjJU[1] = new JsonUtil();
            aobjJU[2] = new JsonUtil();

            if (MyUtil.parseRspMsg(strRsaPrvtExp, strRsaModules, strRspData, ref aobjJU) != 0)
            {
                logPrintf("解析响应报文失败\r\n");
                return;
            }

            strTimeStamp = aobjJU[0].getFiled("timeStamp");
            string strReqSeq = aobjJU[0].getFiled("reqProcSeq");
            strRspSeq = aobjJU[0].getFiled("rspProcSeq");
            string strEncKey = aobjJU[1].getFiled("encKey");
            string strMacKey = aobjJU[1].getFiled("macKey");

            if (strEncKey != null ? (strEncKey.Length <= 0 || (strEncKey.Length % 2) != 0) : true)
            {
                logPrintf("ENC Key格式不合法\r\n");
                return;
            }

            if (strMacKey != null ? (strMacKey.Length <= 0 || (strMacKey.Length % 2) != 0) : true)
            {
                logPrintf("MAC Key格式不合法\r\n");
                return;
            }

            strEncKey = Crypto.rsaOperator(strRsaPrvtExp, strRsaModules, strEncKey);
            strMacKey = Crypto.rsaOperator(strRsaPrvtExp, strRsaModules, strMacKey);

            string strDateTime = MyUtil.formatDate(strTimeStamp.Substring(0,8)) + " " + MyUtil.formatTime(strTimeStamp.Substring(8, 6));

            this.EncKey.Text = strEncKey;
            this.MacKey.Text = strMacKey;
            this.InitDateTime.Text = strDateTime;
            this.InitTimeStamp.Text = strTimeStamp;
            this.InitComReqSeq.Text = strReqSeq;
            this.InitComRspSeq.Text = strRspSeq;

            GlobalData.strSeiTsmEncKey = strEncKey;
            GlobalData.strSeiTsmMacKey = strMacKey;

            m_objIF.IniWriteValue("SeAgentMng", "SeTsmEncKey", strEncKey);
            m_objIF.IniWriteValue("SeAgentMng", "SeTsmMacKey", strMacKey);
            m_objIF.IniWriteValue("SeAgentMng", "SeTsmDateTime", strDateTime);
            m_objIF.IniWriteValue("SeAgentMng", "SeTsmTimeStamp", strTimeStamp);
            m_objIF.IniWriteValue("SeAgentMng", "SeTsmReqSeq", strReqSeq);
            m_objIF.IniWriteValue("SeAgentMng", "SeTsmRspSeq", strRspSeq);

            logPrintf("密钥同步成功\r\n");
            logPrintf("ENC密钥 : " + strEncKey + "\r\n");
            logPrintf("MAC密钥 : " + strMacKey + "\r\n");
            logPrintf("<<<<<<<<<<<<<<<<<<<<<<<<<< 初始化通讯结束 >>>>>>>>>>>>>>>>>>>>>>>>>>>\r\n\r\n");
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            this.ProcLogText.Text = "";
        }
    }
}
