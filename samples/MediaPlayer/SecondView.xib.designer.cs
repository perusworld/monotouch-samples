// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MediaPlayer {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MyStreamingMovieViewController")]
	public partial class MyStreamingMovieViewController {
		
		[MonoTouch.Foundation.Export("playMovieButtonPressed:")]
		partial void playMovieButtonPressed (MonoTouch.UIKit.UIButton sender);

		[MonoTouch.Foundation.Connect("movieURLTextField")]
		private MonoTouch.UIKit.UITextField movieURLTextField {
			get {
				return ((MonoTouch.UIKit.UITextField)(this.GetNativeField("movieURLTextField")));
			}
			set {
				this.SetNativeField("movieURLTextField", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				return ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
			}
			set {
				this.SetNativeField("view", value);
			}
		}
	}
}
