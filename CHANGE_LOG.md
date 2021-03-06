# Real Chute :: Change Log

* 2020-0801: 1.4.8 (stupid_chris) for KSP 1.10.1
	+ Recompiled for KSP 1.10.1
	+ Added DragCube handling for different sizes and when the cap is blown off
	+ Parachutes smoothly move towards the drag vector rather than instantly
	+ Parachutes now look for both horizontal and vertical velocities before cutting
	+ Fixed issue where parachutes would sometimes break due to aero forces underwater
	+ Compatibility back to KSP 1.8 has been enabled
	+ Legacy MM patches removed
* 2020-0318: 1.4.7.6 (stupid_chris) for KSP 1.9
	+ Recompiled and updated for KSP 1.9
* 2019-1016: 1.4.7.5 (stupid_chris) for KSP 1.8
	+ Recompiled and updated for KSP 1.8
* 2019-0413: 1.4.7.4 (stupid_chris) for KSP 1.7
	+ Recompiled for KSP 1.7
* 2019-0127: 1.4.7.3 (stupid_chris) for KSP 1.6
	+ Fix for advanced inventory cross sectional bug. (Adds missing bulkheadProfiles field)
* 2018-1221: 1.4.7.2 (stupid_chris) for KSP 1.6
	+ Recompiled for KSP 1.6
* 2018-1016: 1.4.7.1 (stupid_chris) for KSP 1.5
	+ Recompiled for KSP 1.5
* 2018-1015: 1.4.7 (stupid_chris) for KSP 1.4.5 Localization Issue
	+ Fix for parachute category and parachutes disappearing from VAB in non-english localization installs.
* 2018-0825: 1.4.6.1 (stupid_chris) for KSP 1.4.5
	+ August 25th 2018
		- Recompiled for KSP 1.4.5
* 2018-0320: 1.4.6 (stupid_chris) for KSP 1.4.1
	+ Recompiled for KSP 1.4.1
	+ Has been tested to run on KSP 1.4.0 with no issues detected.
* 2017-1130: 1.4.5 (stupid_chris) for KSP 1.3.1
	+ November 30th 2017
		- Compatibility for KSP 1.3.1
		- Fixed issue with editor window
		- Implemented increments for in flight window sliders
		- Solution-wise code cleanup/optimizations
* 2017-0601: 1.4.4 (stupid_chris) for KSP 1.3.0
	+ June 1st 2017
			- RealChute 1.3 compatibility update
			- Recompiled and fixed missing parameters
			- Updated to CompatibilityChecker 6
			- Fixed custom filters not showing in the editor
			- Fixed settings button appearing in flight
* 2017-0429: 1.4.3.0 (stupid_chris) for KSP 1.2
	+ Removed FAR support: Per discussion with ferram4, it is not necessary to use FAR's methods to get density and there's no real benefit to doing so over stock methods for retrieving density.
* 2017-0325: 1.4.2.0 (stupid_chris) for KSP 1.2
	+ FAR compatibility update. Addresses changes to FARAeroUtil.GetCurrentDensity()
	+ Bring RC chutes in line with stock contract changes. (hopefully prevent impossible chute contracts from being generated by the contract system)
* 2016-1014: 1.4.1.2 (stupid_chris) for KSP 1.2
	+ KSP 1.2 compatibility update
		- Use part.addForceAtPosition instead of calling rigidbody functions (1.2 specific compatibility changes)
		- Updated versioning in RealChute.version and assembly property files
		- Fixed mispelled field name in compatibility checker (_version)
		- Fixed toolbar button showing up in Flight. (broke in 1.2)
* 2016-0430: 1.4.1.1 (stupid_chris) for KSP 1.1.2
	+ April 30th 2016
		- Recompiled for KSP 1.1.2 to prevent nasty PopupDialog exceptions
* 2016-0429: 1.4.1 (stupid_chris) for KSP 1.1.2
	+ April 29th 2016
		- Fixed bug related to reloading the database through ModuleManager
		- Added an OnActive override, potentially fixing a few contract oddities
		- Removed deprecated MM configs
* 2016-0420: 1.4 (stupid_chris) for KSP 1.1
	+ v1.4 - April 19th 2016
		- Removed IPartSizeModifier support (no longer needed)
		- Added search tags to parts
		- Compiled for the latest version of KSP 1.1
* 2016-0416: 1.4x4 (stupid_chris) for KSP 1.0.5 PRE-RELEASE
	+ April 16th 2016
		- Prerelease_
			- New NyanMode™
			- Fixed plugin loading problems from IPartMassModifier and IPartCostModifier
			- Added IPartSizeModifier support
			- Refactored and cleaned the codebase through ReSharper
* 2016-0204: 1.3.2.7 (stupid_chris) for KSP 1.0.5
	+ Changelog:
	+ Fixed an issue with parachutes not having a staging icon when on the same part as one disabling the icon
