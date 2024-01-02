using System;
using System.Collections.Generic;
using System.Data.Common;


namespace Prodwin.Data.Access {

	public class Parametro {
		public string campo;
		public string valor;

		public Parametro() {
		}

		public Parametro(string c, string v) {
			campo = c;
			valor = v;
		}

		public static Parametro NewQ(string c, string v) {
			return new Parametro(c, "'" + v.Replace("'", "''") + "'");
		}

		public static Parametro NewP(string c, string v) {
			return new Parametro(c, v);
		}

		public static Parametro NewP(string c, int v) {
			return new Parametro(c, v.ToString());
		}

		public static Parametro NewP(string c, long v) {
			return new Parametro(c, v.ToString());
		}

		public static Parametro NewP(string c, float v) {
			return new Parametro(c, v.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}

		public static Parametro NewP(string c, double v) {
			return new Parametro(c, v.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}

		public static Parametro NewP(string c, decimal v) {
			return new Parametro(c, v.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
	}


	public class SimpleDataObject {
		public string GerarCampos(List<Parametro> list) {
			string result = "";

			for(int i = 0; i < list.Count; i++) {
				if(i > 0) {
					result += ", ";
				}
				result += list[i].campo;
			}

			return result;
		}

		public string GerarValores(List<Parametro> list) {
			string result = "";

			for(int i = 0; i < list.Count; i++) {
				if(i > 0) {
					result += ", ";
				}
				result += list[i].valor;
			}

			return result;
		}

		public string GerarWhere(List<Parametro> list) {
			string result = "";

			for(int i = 0; i < list.Count; i++) {
				if(i > 0) {
					result += " AND ";
				}
				result += list[i].campo + " = " + list[i].valor;
			}

			return result;
		}

		public string GerarParams(List<Parametro> list) {
			string result = "";

			foreach(Parametro p in list) {
				result += p.campo + " = " + p.valor + ";  ";
			}

			return result;
		}

		public virtual void ParseItem(DbDataReader dr) {
		}
	}

}
