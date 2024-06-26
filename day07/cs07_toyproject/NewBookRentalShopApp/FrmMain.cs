﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        // 각 화면을 초기화
        FrmLoginUser FrmLoginUser = null; // 객체를 메서드로 생성
        FrmBookDivision FrmBookDivision = null;
        FrmBookInfo FrmBookInfo = null;
        FrmMember FrmMember = null; // FrmMember : 클래스 , frmMember : 객체변수
        FrmBookRental frmBookRental = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        // 로드 이벤트핸들러, 로그인창을 먼저 띄어야 함
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true; // 가장 윈도우화면 상단에 
            frm.ShowDialog();

            LblLoginId.Text = Helper.Common.LoginId;
        }

        private void MnuLoginUsers_Click(object sender, EventArgs e)
        {
            // 이미 창이 열려있으면 새로 생성할 필요가 없기 때문에
            // 이런 작업을 안하면 메뉴 클릭시마다 새 폼이 열림
            FrmLoginUser = ShowActiveForm(FrmLoginUser, typeof(FrmLoginUser)) as FrmLoginUser;
        }

        // 책 장르관리 메뉴 클릭 이벤트핸들러
        private void MnuBookDivision_Click(object sender, EventArgs e)
        {
            FrmBookDivision = ShowActiveForm(FrmBookDivision, typeof(FrmBookDivision)) as FrmBookDivision;
        }
        private void MnuBookInfo_Click(object sender, EventArgs e)
        {
            FrmBookInfo = ShowActiveForm(FrmBookInfo, typeof(FrmBookInfo)) as FrmBookInfo;
        }

        private void MnuMembers_Click(object sender, EventArgs e)
        {
            FrmMember = ShowActiveForm(FrmMember, typeof(FrmMember)) as FrmMember;
        }

        private void MnuBookRental_Click(object sender, EventArgs e)
        {
            frmBookRental = ShowActiveForm(frmBookRental, typeof(FrmBookRental)) as FrmBookRental;
        }

        Form ShowActiveForm(Form form, Type type)
        {
            if (form == null) // 화면이 한번도 안열었으면
            {
                form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입
                form.MdiParent = this; // 자식창의 부모는 FrmMain
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed) // 창이 한번 닫혔으면
                {
                    form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입
                    form.MdiParent = this; // 자식창의 부모는 FrmMain
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창을 그냥 최소화, 열려있으면
                {
                    form.Activate(); // 화면에 열려있는 창을 활성화
                }
            }
            return form;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true; // 종료 안되는 부분
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout popup = new FrmAbout();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
    }
}
