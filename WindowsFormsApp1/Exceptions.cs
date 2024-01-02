using System;


namespace Prodwin.Data.Access {

	[Serializable]
	public class MwDbException: Exception {
		public MwDbException(string msg)
			: base(msg) {
		}

		public MwDbException(string msg, Exception ex)
			: base(msg, ex) {
		}
	}

	[Serializable]
	public class DataIntegrityException: Exception {
		public DataIntegrityException(string message, Exception ex)
			: base(message, ex) {
		}
		public DataIntegrityException(string message)
			: base(message) {
		}
	}

	[Serializable]
	public class DataUKViolationException: Exception {
		public DataUKViolationException(string message, Exception ex)
			: base(message, ex) {
		}
	}
}
