// <assemblyHash>f4bf3d19</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=11.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias mqttf;
extern alias rf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("ReadingFiles", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("ReadingFiles")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace ReadingFiles.Fakes
{
    /// <summary>Shim type of ReadingFiles.FileReader</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(rf::ReadingFiles.FileReader))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of FileReader")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public sealed partial class ShimFileReader
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase
    {
        /// <summary>Initializes a new shim instance</summary>
        private ShimFileReader()
        : base(typeof(rf::ReadingFiles.FileReader))
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::ReadingFiles.Fakes.ShimFileReader.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::ReadingFiles.Fakes.ShimFileReader.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(rf::ReadingFiles.FileReader), value);
            }
        }

        /// <summary>Sets the mole of FileReader.IsFileEmpty(IFileSystem fileSystem, String fileName)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<rf::ReadingFiles.IFileSystem, string, bool> IsFileEmptyIFileSystemString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("IsFileEmpty", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(rf::ReadingFiles.FileReader), 
                     "IsFileEmpty", typeof(bool), new global::System.Type[]{typeof(rf::ReadingFiles.IFileSystem), typeof(string)});
            }
        }
    }
}
namespace ReadingFiles.Fakes
{
    /// <summary>Shim type of ReadingFiles.FileSystem</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(rf::ReadingFiles.FileSystem))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of FileSystem")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimFileSystem
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<rf::ReadingFiles.FileSystem>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimFileSystem()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimFileSystem(rf::ReadingFiles.FileSystem instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the mole of FileSystem.ReadAllText(String fileName)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<rf::ReadingFiles.FileSystem, string, string> ReadAllTextString
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("ReadAllText", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(rf::ReadingFiles.FileSystem), (object)null, 
                         "ReadAllText", typeof(string), new global::System.Type[]{typeof(string)});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::ReadingFiles.Fakes.ShimFileSystem.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::ReadingFiles.Fakes.ShimFileSystem.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(rf::ReadingFiles.FileSystem), value);
            }
        }

        /// <summary>Binds the members of the interface to the shim.</summary>
        public global::ReadingFiles.Fakes.ShimFileSystem Bind(rf::ReadingFiles.IFileSystem target)
        {
            if (target == (rf::ReadingFiles.IFileSystem)null)
              throw new global::System.ArgumentNullException("target");
            mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime
              .Bind<rf::ReadingFiles.FileSystem, global::ReadingFiles.Fakes.ShimFileSystem, rf::ReadingFiles.IFileSystem>(this, target);
            return this;
        }

        /// <summary>Sets the mole of FileSystem.FileSystem()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<rf::ReadingFiles.FileSystem> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(rf::ReadingFiles.FileSystem), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the mole of FileSystem.ReadAllText(String fileName)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, string> ReadAllTextString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("ReadAllText", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<rf::ReadingFiles.FileSystem, string, string>(value)), 
                                                                                                    typeof(rf::ReadingFiles.FileSystem), base.Instance, "ReadAllText", typeof(string), new global::System.Type[]{typeof(string)});
            }
        }
    }
}
namespace ReadingFiles.Fakes
{
    /// <summary>Stub type of ReadingFiles.FileSystem</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(rf::ReadingFiles.FileSystem))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of FileSystem")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubFileSystem
      : rf::ReadingFiles.FileSystem
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubFileSystem()
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.__callBase;
            }
            set
            {
                this.__callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubFileSystem</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.__instanceBehavior);
            }
            set
            {
                this.__instanceBehavior = value;
            }
        }

        private bool __callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior __instanceBehavior;
    }
}
namespace ReadingFiles.Fakes
{
    /// <summary>Stub type of ReadingFiles.IFileSystem</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(rf::ReadingFiles.IFileSystem))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of IFileSystem")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubIFileSystem
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBase
      , rf::ReadingFiles.IFileSystem
    {
        /// <summary>Initializes a new instance of type StubIFileSystem</summary>
        public StubIFileSystem()
        {
        }

        /// <summary>Sets the stub of IFileSystem.ReadAllText(String fileName)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, string> ReadAllTextString;

        /// <summary>Sets the stub of IFileSystem.ReadAllText(String fileName)</summary>
        string rf::ReadingFiles.IFileSystem.ReadAllText(string fileName)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, string> sh = this.ReadAllTextString;
            if ((object)sh != (object)null)
              return sh.Invoke(fileName);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior _behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return _behavior.Result<global::ReadingFiles.Fakes.StubIFileSystem, string>(this, "ReadingFiles.IFileSystem.ReadAllText");
            }
        }
    }
}
