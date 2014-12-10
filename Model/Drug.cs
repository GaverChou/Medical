using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Drug
    {
        public Drug() { }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int drug_id;

        public int Drug_id
        {
            get { return drug_id; }
            set { drug_id = value; }
        }
        private string drug_ab;

        public string Drug_ab
        {
            get { return drug_ab; }
            set { drug_ab = value; }
        }
        private string drug_name;

        public string Drug_name
        {
            get { return drug_name; }
            set { drug_name = value; }
        }
        private double unit_price;

        public double Unit_price
        {
            get { return unit_price; }
            set { unit_price = value; }
        }
        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        private double in_price;

        public double In_price
        {
            get { return in_price; }
            set { in_price = value; }
        }
        private double stock;

        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private string from_where;

        public string From_where
        {
            get { return from_where; }
            set { from_where = value; }
        }
        private string wei_jin;

        public string Wei_jin
        {
            get { return wei_jin; }
            set { wei_jin = value; }
        }
        private string notice;

        public string Notice
        {
            get { return notice; }
            set { notice = value; }
        }
        private string effect;

        public string Effect
        {
            get { return effect; }
            set { effect = value; }
        }
        private double use_up;

        public double Use_up
        {
            get { return use_up; }
            set { use_up = value; }
        }
        private double use_down;

        public double Use_down
        {
            get { return use_down; }
            set { use_down = value; }
        }
    }
}
