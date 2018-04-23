using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace NavBarExample.Module.BusinessObjects {
    [NavigationItem("Group1")]
    public class DomainObject1 : BaseObject {
        public DomainObject1(Session session)
            : base(session) { }
    }
    [NavigationItem("Group1")]
    public class DomainObject2 : BaseObject {
        public DomainObject2(Session session)
            : base(session) { }
    }
    [NavigationItem("Group1")]
    public class DomainObject3 : BaseObject {
        public DomainObject3(Session session)
            : base(session) { }
    }
    [NavigationItem("Group2")]
    public class DomainObject4 : BaseObject {
        public DomainObject4(Session session)
            : base(session) { }
    }
    [NavigationItem("Group2")]
    public class DomainObject5 : BaseObject {
        public DomainObject5(Session session)
            : base(session) { }
    }
    [NavigationItem("Group2")]
    public class DomainObject6 : BaseObject {
        public DomainObject6(Session session)
            : base(session) { }
    }
    [NavigationItem("Group3")]
    public class DomainObject7 : BaseObject {
        public DomainObject7(Session session)
            : base(session) { }
    }
}
