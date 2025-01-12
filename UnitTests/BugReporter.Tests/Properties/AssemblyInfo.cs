﻿using ApprovalTests.Reporters;
using ApprovalTests.Reporters.ContinuousIntegration;
using ApprovalTests.Reporters.TestFrameworks;
using CommonTestUtils;

[assembly: TestAppSettings]
[assembly: UseReporter(typeof(NUnitReporter), typeof(AppVeyorReporter), typeof(DiffReporter))]
[assembly: NUnit.Framework.Category("UnitTests")]
