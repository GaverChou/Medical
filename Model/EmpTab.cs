using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class EmpTab
    {
        private int em_id;

        public int Em_id
        {
            get { return em_id; }
            set { em_id = value; }
        }
        private string em_name;

        public string Em_name
        {
            get { return em_name; }
            set { em_name = value; }
        }
        private string em_ab;

        public string Em_ab
        {
            get { return em_ab; }
            set { em_ab = value; }
        }
        private string from_where;

        public string From_where
        {
            get { return from_where; }
            set { from_where = value; }
        }
        private string effect;

        public string Effect
        {
            get { return effect; }
            set { effect = value; }
        }
        private string cure;

        public string Cure
        {
            get { return cure; }
            set { cure = value; }
        }
        private string minus_and_add;

        public string Minus_and_add
        {
            get { return minus_and_add; }
            set { minus_and_add = value; }
        }
        private string fangjie;

        public string Fangjie
        {
            get { return fangjie; }
            set { fangjie = value; }
        }
        private string apply;

        public string Apply
        {
            get { return apply; }
            set { apply = value; }
        }
    }
}
