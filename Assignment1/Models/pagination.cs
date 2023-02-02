namespace Assignment1.Models
{
    public class pagination
    {
        public int Totalitem { get; set; }
        public int Currpage { get; set; }
        public int Pagesize { get; set; }
        public int Totalpage { get; set; }
        public int Startpage { get; set; }
        public int Endpage { get; set; }

        public pagination()
        {
                
        }

        public pagination(int totalitem, int page, int pagesize = 10)
        {
            int totalpage = (int)Math.Ceiling((decimal)totalitem / (decimal)pagesize);
            int currpage = page;

            int startpage = currpage - 5;
            int endpage = currpage + 4;

            if (startpage <= 0)
            { 
                endpage = endpage - (startpage - 1);
                startpage = 1;
            }

            if (endpage > totalpage)
            { 
                endpage = totalpage;
                if (endpage > 10)
                { 
                    startpage = startpage - 9;
                }
            }

            Totalitem = totalitem;
            Currpage = currpage;
            Pagesize = pagesize;
            Totalpage = totalpage;
            Startpage = startpage;
            Endpage = endpage;
        }


    }
}


