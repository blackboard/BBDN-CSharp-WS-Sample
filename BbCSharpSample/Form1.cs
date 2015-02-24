/* Copyright (C) 2015, Blackboard Inc.
 * All rights reserved.
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *
 *  -- Redistributions of source code must retain the above copyright
 *     notice, this list of conditions and the following disclaimer.
 *
 *  -- Redistributions in binary form must reproduce the above copyright
 *     notice, this list of conditions and the following disclaimer in the
 *     documentation and/or other materials provided with the distribution.
 *
 *  -- Neither the name of Blackboard Inc. nor the names of its contributors 
 *     may be used to endorse or promote products derived from this 
 *     software without specific prior written permission.
 *  
 * THIS SOFTWARE IS PROVIDED BY BLACKBOARD INC ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL BLACKBOARD INC. BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioTool_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selected Proxy Tool, they don't need to enter a username or password
            if(radioTool.Checked==true) {
                txtUsername.Enabled = false;
                txtUserPasswd.Enabled = false;
            } else {
                // if the user selected user, they do need to enter a username and password
                txtUsername.Enabled = true;
                txtUserPasswd.Enabled = true;
            }
        }

        private void cbRegister_CheckedChanged(object sender, EventArgs e)
        {
            // If the user checks the box to register the tool, they may need to enter a registration password
            if (cbRegister.Checked == true)
                txtRegPasswd.Enabled = true;
            else
                txtRegPasswd.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // If the user needs to register the proxy tool...
            if (cbRegister.Checked == true)
            {
                // Call the code to register the proxy tool
                Boolean registered = Program.registerTool(txtHost.Text, txtVendorId.Text, txtProgramId.Text, txtSharedSecret.Text, txtRegPasswd.Text);

                if (registered)
                    txtCourseList.Text = "Tool registration complete. Please approve the Proxy Tool in the Blackboard Learn System Admin panel.";
                else
                    txtCourseList.Text = "Tool registration failed.";

            }
            else
            {

                String loginType = "tool";

                if (radioUser.Checked)
                    loginType = "user";

                // Call the function to build the courseList for the given user.
                String[,] courseList = Program.getData(txtHost.Text, txtVendorId.Text, txtProgramId.Text, txtSharedSecret.Text, txtUsername.Text, txtUserPasswd.Text, loginType, txtCourseUser.Text);

                // If the getData method returned data...
                if (courseList != null)
                {
                    // Iterate through the courseList and append it to the courselist text box.
                    for (int i = 0; i < 10000; i++)
                    {
                        if (courseList[i, 0] != null)
                        {
                            txtCourseList.Text = txtCourseList.Text + courseList[i, 0] + "," + courseList[i, 1] + "," + courseList[i, 2] + "," + courseList[i, 3] + Environment.NewLine;
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the course list text box
            txtCourseList.ResetText();
        }

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
