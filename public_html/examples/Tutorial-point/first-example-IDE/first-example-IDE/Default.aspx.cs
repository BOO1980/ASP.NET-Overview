﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        string buf = TextBox1.Text;
        changed_text.InnerHtml = buf.ToUpper();

    }
}