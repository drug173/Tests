using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_megaperfume2
{
    public partial class Form1 : Form
    {
        testEntities db = new testEntities();
        Guid idPrice = Guid.NewGuid();// id выбранного прайса
        Guid idDis = Guid.NewGuid();//id выбранного поставщика
        int numCriterion = 0;//номер критерия
        List<DISTRIBUTORS> listDistributors = new List<DISTRIBUTORS>();//Список поставщиков
        List<PRICES> listPrices = new List<PRICES>();//список прайсов для выбранного поставщика

        string priceName1 = null;
        string disName1 = null;

       
       
        


        #region
        public Form1()
        {
            
           InitializeComponent();

            criterion.SelectedIndex = 0;
          
           
      

            // выбираем поставщиков из базы
            var nameD = (from pr in db.DISTRIBUTORS
                         select pr);

            foreach (var item in nameD)
            {
                listDistributors.Add(new DISTRIBUTORS { NAME = item.NAME, ID = item.ID });
            }
            distributors.DataSource = listDistributors;//привязываем ;
            distributors.DisplayMember = "NAME";
            distributors.ValueMember = "ID";





        }
        #endregion

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region
        private void button1_Click(object sender, EventArgs e)
        {

            int rowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowsCount - 1; i++)
            {
                this.dataGridView1.Rows.RemoveAt(0);
            }


            //  System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@ID1", idPrice);
            // var productsQuery = db.Database.SqlQuery<PRODUCTS>("SELECT PRODUCTS.* FROM  PRODUCTS, PRICESRECORDS, LINKS WHERE( PRICESRECORDS.PRICEID = @ID1 AND PRODUCTS.ID =LINKS.CATALOGPRODUCTID AND LINKS.PRICERECORDINDEX=PRICESRECORDS.RECORDINDEX  )", param1);
            int row = 0;
            double d = 0, minP = -1, maxP = -1;
            Guid priceDis = Guid.NewGuid();
            Guid? disId = Guid.NewGuid();
            Guid idP;
            List<Guid> priceList;//список прайс-листов с минимальной ценой товара
            string priceListName;///список прайс-листов с минимальной ценой товара


            //список товаров выбранного прайса
            var productQuery = (from product1 in db.PRODUCTS             
                            join lk in db.LINKS on product1.ID equals lk.CATALOGPRODUCTID 
                            join prise1 in db.PRICESRECORDS on lk.PRICERECORDINDEX equals prise1.RECORDINDEX where prise1.USED==true && prise1.DELETED==false && prise1.PRICEID == idPrice
                                join pr1 in db.PRICES on prise1.PRICEID equals pr1.ID
                            join dis1 in db.DISTRIBUTORS on pr1.DISID equals dis1.ID where dis1.ACTIVE==true
                            
                            select product1);



            foreach (var p in productQuery)
            {
                priceList = new List<Guid>();
                priceListName=null;
                priceName1 = null;
               disName1 = null;
                //цена товара  по прайсу выбранного прайса
                var priceP = (from pr1 in db.PRICESRECORDS
                              where pr1.PRICEID == idPrice //&& pr.PRICE != 0
                              join lk1 in db.LINKS on pr1.RECORDINDEX equals lk1.PRICERECORDINDEX 
                              where lk1.CATALOGPRODUCTID == p.ID
                              select pr1.PRICE);
                
                foreach (var tt in priceP)
                {
                    d = tt;
                }
                idP = p.ID;

                       //минимальная цена товара из других прайсов КРОМЕ ЦЕНЫ НОЛЬ
                    var priceMin = (from pr in db.PRICESRECORDS
                                    where pr.PRICEID != idPrice && pr.PRICE != 0 && pr.USED == true && pr.DELETED == false
                                    join lk in db.LINKS on pr.RECORDINDEX equals lk.PRICERECORDINDEX 
                                     where lk.CATALOGPRODUCTID == p.ID
                                    join price in db.PRICES on pr.PRICEID equals price.ID
                                    join distrib in db.DISTRIBUTORS on price.DISID equals distrib.ID
                                    where distrib.ACTIVE == true
                                    select pr);

                    minP = -1; maxP = -1;
                    foreach (var p3 in priceMin)
                    {

                        if (minP == -1)
                        {
                            maxP = p3.PRICE;
                            minP = p3.PRICE;
                        priceDis = p3.PRICEID;
                        priceList.Add(p3.PRICEID);
                    }

                        if (minP > p3.PRICE)
                        {
                            minP = p3.PRICE;
                        priceList.Clear();
                            priceDis = p3.PRICEID;
                        priceList.Add(p3.PRICEID);
                        }
                        if (maxP < p3.PRICE)
                        {
                            maxP = p3.PRICE;
                        }
                        if (minP == p3.PRICE)
                        {
                            priceList.Add(p3.PRICEID);

                        }
                    }



                #region//критерий ВСЕ
                if (numCriterion == 3 || numCriterion == 0)//ВСЕ
                {
                    if (minP == -1)
                    {

                        dataGridView1.Rows.Add(p.ID, p.NAME + " " + p.CHILDNAME, d, "--", "--", "--", "--", "--", "--", "других поставщиков нет");

                        dataGridView1[2, row].Style.BackColor = Color.Gray; row++;
                    }
                    else
                    {
                        var priceName = (from pr in db.PRICES
                                         where pr.ID == priceDis
                                         select pr);
                        foreach (var pN in priceName)
                        {
                            priceName1 = pN.NAME;
                            disId = pN.DISID;
                        }
                        var disName = (from pr in db.DISTRIBUTORS
                                       where pr.ID == disId
                                       select pr.NAME);
                        foreach (var dN in disName)
                        {
                            disName1 = dN;

                        }

                        foreach(var item in priceList)
                        {

                            var priceMinList = (from pr in db.PRICES
                                            where pr.ID==item
                                           select pr.NAME);
                            foreach(var item2 in priceMinList)
                            {
                                if (priceListName == null)
                                {
                                    priceListName = item2;
                                }
                                else
                                {
                                    if (priceListName.Contains(item2) == false)
                                    {
                                        priceListName += ", " + item2;
                                    }
                                }
                            }
                        }



                        dataGridView1.Rows.Add(p.ID, p.NAME + " " + p.CHILDNAME, d, minP, d - minP, maxP,d- maxP, disName1, priceName1, priceListName);

                        if (minP < d)
                        {
                            dataGridView1[3, row].Style.BackColor = Color.Green;
                            dataGridView1[2, row].Style.BackColor = Color.Red;

                        }
                        row++;
                    }

                }
                #endregion

                #region//критерий Минимальная цена у ДРУГИХ
                if (numCriterion == 1)//меньшая цена у других
                {       //минимальная цена товара из других прайсов КРОМЕ ЦЕНЫ НОЛЬ
  
                    if (minP == -1)
                    {

                        dataGridView1.Rows.Add(idP, p.NAME + " " + p.CHILDNAME, d, "--", "--", "--", "--", "--", "--", "других поставщиков нет");

                        dataGridView1[2, row].Style.BackColor = Color.Gray;
                        row++;
                    }
                    else
                    {
                        var priceName = (from pr in db.PRICES
                                         where pr.ID == priceDis
                                         select pr);
                        foreach (var pN in priceName)
                        {
                            priceName1 = pN.NAME;
                            disId = pN.DISID;
                        }
                        var disName = (from pr in db.DISTRIBUTORS
                                       where pr.ID == disId
                                       select pr.NAME);
                        foreach (var dN in disName)
                        {
                            disName1 = dN;

                        }

                        if (d <= minP)
                        {
                            dataGridView1.Rows.Add(idP,p.NAME + " " + p.CHILDNAME, d, "", "", maxP, d - maxP, disName1, priceName1, priceListName);

                        }
                        else
                        {
                            dataGridView1.Rows.Add(idP,p.NAME + " " + p.CHILDNAME, d, minP, d - minP, maxP, d - maxP, disName1, priceName1, priceListName);

                            dataGridView1[3, row].Style.BackColor = Color.Green;
                            dataGridView1[2, row].Style.BackColor = Color.Red;

                        }

                        row++;
                    }

                }
                #endregion

                #region//критерий Минимальная цена ЗДЕСЬ
                if (numCriterion == 2)//меньшая цена здесь
                {       //минимальная цена товара из других прайсов КРОМЕ ЦЕНЫ НОЛЬ

                  
                    if (minP == -1)
                    {

                        dataGridView1.Rows.Add(idP,p.NAME + " " + p.CHILDNAME, d, "--", "--", "--", "--", "--", "--", "других поставщиков нет");
                        dataGridView1[2, row].Style.BackColor = Color.Green;
                        row++;
                    }
                    else
                    {
                        var priceName = (from pr in db.PRICES
                                         where pr.ID == priceDis
                                         select pr);
                        foreach (var pN in priceName)
                        {
                            priceName1 = pN.NAME;
                            disId = pN.DISID;
                        }
                        var disName = (from pr in db.DISTRIBUTORS
                                       where pr.ID == disId
                                       select pr.NAME);
                        foreach (var dN in disName)
                        {
                            disName1 = dN;

                        }

                        if (d <= minP)
                        {
                            dataGridView1.Rows.Add(idP,p.NAME + " " + p.CHILDNAME, d, "", "", maxP, d - maxP, " ", "", "-");
                            dataGridView1[2, row].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            dataGridView1.Rows.Add(idP,p.NAME + " " + p.CHILDNAME, d, minP, d - minP, maxP, d - maxP, disName1, priceName1, "-");

                           
                            dataGridView1[2, row].Style.BackColor = Color.Red;

                        }

                        row++;
                    }




                }
                #endregion
            }//////////////////////////////////////////////




        }
        #endregion

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet3.DISTRIBUTORS". При необходимости она может быть перемещена или удалена.
            this.dISTRIBUTORSTableAdapter.Fill(this.testDataSet3.DISTRIBUTORS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet2.PRICES". При необходимости она может быть перемещена или удалена.
            this.pRICESTableAdapter.Fill(this.testDataSet2.PRICES);
           

        }
        #endregion

        #region//выбираем прайс
        private void prices_SelectedIndexChanged(object sender, EventArgs e)
        {
            criterion.SelectedIndex = 0;
            idPrice = Guid.Parse(prices.SelectedValue.ToString());//id выбранного прайса 
        }
        #endregion

        #region//выбираем критерий
        private void criterion_SelectedIndexChanged(object sender, EventArgs e)
        {

            numCriterion = int.Parse(criterion.SelectedIndex.ToString());//номер выбранного критерия
        }
        #endregion

        #region//выбираем поставщика и создаём список  прайсов
        private void distributors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPrices.Clear();
            idDis = Guid.Parse(distributors.SelectedValue.ToString());//Id выбранного поставщика из таблицы поставщиков
            criterion.SelectedIndex = 0;
            
            //System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@ID1", idDis);
            // var pricesQuery = db.Database.SqlQuery<PRICES>("SELECT * FROM PRICES WHERE( PRICES.DISID = @ID1 )", param);

            //получаем список прайсов выбранного поставщика
            listPrices = new List<PRICES>();
            listPrices.Add(new PRICES { NAME = "выберите прайс" });
            var priceP = (from pr in db.PRICES
                          where pr.DISID == idDis  
                          select pr);
            foreach (var item in priceP)
            {
                listPrices.Add(new PRICES { NAME = item.NAME, ID = item.ID });
            }
            prices.DataSource = listPrices;//привязываем список прайсов к combobox (prices);
            prices.DisplayMember = "NAME";
            prices.ValueMember = "ID";
        }
        #endregion

        #region
        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowsCount = dataGridView2.Rows.Count;
            for (int i = 0; i < rowsCount - 1; i++)
            {
                this.dataGridView2.Rows.RemoveAt(0);
            }

            string nameDis = null;//поставщик
            double diffPrice8 =0;//разница в цене
            string namePr8=null;//прайс
            string nameProd8 = null;//название товара
            Guid? idProducts8=null;

            if (e.RowIndex < 0)
                return;

            //id товара выбранного в первой таблице
             rowsCount = dataGridView1.Rows.Count;
            if (rowsCount != 1 && e.RowIndex!=rowsCount-1)
            {
                 idProducts8 = Guid.Parse(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
            }
            //по ID поставщика и прайса получаем имена  поставщика и прайса
            var nameD = (from pr in db.DISTRIBUTORS
                         where pr.ID == idDis
                         join lk in db.PRICES on pr.ID equals lk.DISID 
                         where lk.ID == idPrice
                         let namePrise = lk.NAME
                         let nameDistr = pr.NAME      
                         select new { nameDistr, namePrise });
            foreach (var item in nameD)
            {
                nameDis = item.nameDistr;//поставщик  выбранного товара
                namePr8 = item.namePrise;//прайс выбранного товара
            }

            //получаем название товара по ID 
            var priceRecName = (from pr in db.PRICESRECORDS
                                where pr.PRICEID == idPrice
                                join lk in db.LINKS on pr.RECORDINDEX equals lk.PRICERECORDINDEX
                               where lk.CATALOGPRODUCTID== idProducts8                        
                               select pr.NAME);
            foreach(var item in priceRecName)
            {
                 nameProd8 = item;// название выбранного товара
            }

           
            double price8 = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            var priceMin8 = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            if (priceMin8 is double)
            {
                diffPrice8 = price8 - Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            }
            else
            {
                diffPrice8 = 0;
            }
            //первая строка, запись из базавого прайса
            dataGridView2.Rows.Add(nameDis, namePr8, nameProd8, price8, diffPrice8);
            dataGridView2.Rows[0].DefaultCellStyle.BackColor = Color.DodgerBlue;

          

            //получаем остальные записи прайс листов с данным товаром
            var priceRec = (from pr in db.PRICESRECORDS 
                            where pr.PRICEID!= idPrice && pr.PRICE!=0 && pr.USED == true && pr.DELETED == false
                            join lk in db.LINKS on pr.RECORDINDEX equals lk.PRICERECORDINDEX
                            where lk.CATALOGPRODUCTID == idProducts8
                            join price in db.PRICES on pr.PRICEID equals price.ID
                            let namePrice2=price.NAME
                            let nameProd=pr.NAME
                            let price9=pr.PRICE
                            join distrib in db.DISTRIBUTORS on price.DISID equals distrib.ID where distrib.ACTIVE==true
                            let distribName= distrib.NAME
                            orderby price9
                            select new { nameProd, namePrice2, price9,distribName });
            int row2 = 1;
            foreach(var item in priceRec)
            {

                diffPrice8 = item.price9- price8;
                dataGridView2.Rows.Add(item.distribName, item.namePrice2, item.nameProd, item.price9, diffPrice8);
                if (diffPrice8 < 0)
                {
                    dataGridView2.Rows[row2].DefaultCellStyle.BackColor = Color.Green;

                }
                row2++;
            }






        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
