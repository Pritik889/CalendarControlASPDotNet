using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //bithdaydaylist is a variable type HasTable.
        bithdaydaylist = UserRelatedData();
    }
    /// <summary>
    /// this event fire when calender control load on your web page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        //Here i hav eto create lable class object.
        Label lbl = new Label();
        //some text which you want to display on each day
        lbl.BackColor = Color.Green;
        //Here get datafor particular date from bithdaydaylist.
        lbl.Text = "<br />" + (string)bithdaydaylist[e.Day.Date.ToShortDateString()];
        //Add control to the each day of month.
        e.Cell.Controls.Add(lbl);

        //using this code  apply validation on day of calender control
        //using this you can restrict the accesse of day.Make day not selectable.
        if (e.Day.Date >= DateTime.Now.Date && e.Day.Date <= DateTime.Now.AddDays(30))
            e.Day.IsSelectable = true;
        else
            e.Day.IsSelectable = false;

    }

    /// <summary>
    /// Declare global variable.
    /// </summary>
    Hashtable bithdaydaylist;
    /// <summary>
    /// Here i have create the data for particular date.
    /// which is display on caledar control date.
    /// you can use datasource as Sqlserver database.
    /// Here My datasource is Hastable (Collection).
    /// </summary>
    private Hashtable UserRelatedData()
    {
        Hashtable _ht = new Hashtable();

        _ht["1/1/2014"] = "priti b'day";
        _ht["1/26/2014"] = "Anu b'day";
        _ht["1/29/2014"] = "Rekha b'day";
        _ht["1/23/2014"] = "Rohan b'day";
        _ht["1/27/2014"] = "Sikha b'day";
        return _ht;
    }







}