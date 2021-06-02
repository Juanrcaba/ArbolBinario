using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
	public class Nodo
	{
		private int _Data;
		private Nodo _Right, _Left;

		public Nodo()
		{
			this.Data = 0;
			Right = null;
			Left = null;
		}

        public int Data { get => _Data; set => _Data = value; }
        public Nodo Right { get => _Right; set => _Right = value; }
        public Nodo Left { get => _Left; set => _Left = value; }
    }
}
