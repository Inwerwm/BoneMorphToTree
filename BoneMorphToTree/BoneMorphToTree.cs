using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoneMorphToTree
{
    class BoneMorphToTree
    {
        public IPXMorph Morph { get; set; }
        public IPXBone ParentBone { get; set; }

        public IEnumerable<IPXBone> CreateBoneByMorph(bool hasMakeMove, bool hasMakeRotate)
        {
            var createdBones = new List<IPXBone>();

            if (Morph == null)
                throw new InvalidOperationException("対象モーフが選択されていません。");
            if (ParentBone == null)
                throw new InvalidOperationException("親ボーンが選択されていません。");

            IPXBone rootBone = CreateChildBone(ParentBone);
            rootBone.Name = Morph.Name;

            if (hasMakeMove)
                createdBones.AddRange(CreateMoveBones(rootBone));
            if (hasMakeRotate)
                createdBones.AddRange(CreateRotateBones(rootBone));

            return createdBones;
        }

        private IPXBone CreateChildBone(IPXBone parent)
        {
            IPXBone child = parent.Clone() as IPXBone;
            child.Parent = parent;
            child.IsIK = false;

            return child;
        }

        private IEnumerable<IPXBone> CreateMoveBones(IPXBone root)
        {


        }


        private IEnumerable<IPXBone> CreateRotateBones(IPXBone root)
        {

        }
    }
}
