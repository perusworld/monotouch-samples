// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoCatalog {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("ToolbarViewController")]
	public partial class ToolbarViewController {
		
		[MonoTouch.Foundation.Export("toggleStyle:")]partial void toggleStyle (MonoTouch.UIKit.UISegmentedControl sender);

		[MonoTouch.Foundation.Export("toggleBarStyle:")]partial void toggleBarStyle (MonoTouch.UIKit.UISegmentedControl sender);

		[MonoTouch.Foundation.Export("toggleTintColor:")]partial void toggleTintColor (MonoTouch.UIKit.UISwitch sender);

		[MonoTouch.Foundation.Connect("view")]
		protected MonoTouch.UIKit.UIView view {
			get {
				return ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
			}
			set {
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("barStyleSegControl")]
		protected MonoTouch.UIKit.UISegmentedControl barStyleSegControl {
			get {
				return ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("barStyleSegControl")));
			}
			set {
				this.SetNativeField("barStyleSegControl", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("buttonItemStyleSegControl")]
		protected MonoTouch.UIKit.UISegmentedControl buttonItemStyleSegControl {
			get {
				return ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("buttonItemStyleSegControl")));
			}
			set {
				this.SetNativeField("buttonItemStyleSegControl", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("systemButtonPicker")]
		protected MonoTouch.UIKit.UIPickerView systemButtonPicker {
			get {
				return ((MonoTouch.UIKit.UIPickerView)(this.GetNativeField("systemButtonPicker")));
			}
			set {
				this.SetNativeField("systemButtonPicker", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("tintSwitch")]
		protected MonoTouch.UIKit.UISwitch tintSwitch {
			get {
				return ((MonoTouch.UIKit.UISwitch)(this.GetNativeField("tintSwitch")));
			}
			set {
				this.SetNativeField("tintSwitch", value);
			}
		}
	}
}
