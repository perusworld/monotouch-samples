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
	[MonoTouch.Foundation.Register("PickerViewController")]
	public partial class PickerViewController {
		
		[MonoTouch.Foundation.Export("togglePickerStyle:")]partial void togglePickerStyle (MonoTouch.UIKit.UISegmentedControl sender);

		[MonoTouch.Foundation.Export("togglePickers:")]partial void togglePickers (MonoTouch.UIKit.UIBarButtonItem sender);

		[MonoTouch.Foundation.Connect("view")]
		protected MonoTouch.UIKit.UIView view {
			get {
				return ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
			}
			set {
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("buttonBarSegmentedControl")]
		protected MonoTouch.UIKit.UISegmentedControl buttonBarSegmentedControl {
			get {
				return ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("buttonBarSegmentedControl")));
			}
			set {
				this.SetNativeField("buttonBarSegmentedControl", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("pickerStyleSegmentedControl")]
		protected MonoTouch.UIKit.UISegmentedControl pickerStyleSegmentedControl {
			get {
				return ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("pickerStyleSegmentedControl")));
			}
			set {
				this.SetNativeField("pickerStyleSegmentedControl", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("segmentLabel")]
		protected MonoTouch.UIKit.UILabel segmentLabel {
			get {
				return ((MonoTouch.UIKit.UILabel)(this.GetNativeField("segmentLabel")));
			}
			set {
				this.SetNativeField("segmentLabel", value);
			}
		}
	}
}
