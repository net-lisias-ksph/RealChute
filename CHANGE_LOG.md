# Real Chute :: Change Log

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
