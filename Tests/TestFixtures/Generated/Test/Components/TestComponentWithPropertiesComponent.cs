//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public ComponentWithProperties componentWithProperties { get { return (ComponentWithProperties)GetComponent(TestComponentLookup.ComponentWithProperties); } }
    public bool hasComponentWithProperties { get { return HasComponent(TestComponentLookup.ComponentWithProperties); } }

    public void AddComponentWithProperties(string newPublicProperty) {
        var index = TestComponentLookup.ComponentWithProperties;
        var component = CreateComponent<ComponentWithProperties>(index);
        component.publicProperty = newPublicProperty;
        AddComponent(index, component);
    }

    public void ReplaceComponentWithProperties(string newPublicProperty) {
        var index = TestComponentLookup.ComponentWithProperties;
        var component = CreateComponent<ComponentWithProperties>(index);
        component.publicProperty = newPublicProperty;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentWithProperties() {
        RemoveComponent(TestComponentLookup.ComponentWithProperties);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherComponentWithProperties;

    public static Entitas.IMatcher<TestEntity> ComponentWithProperties {
        get {
            if (_matcherComponentWithProperties == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentLookup.ComponentWithProperties);
                matcher.componentNames = TestComponentLookup.componentNames;
                _matcherComponentWithProperties = matcher;
            }

            return _matcherComponentWithProperties;
        }
    }
}
