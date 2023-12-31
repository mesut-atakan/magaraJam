using UnityEngine;


namespace Inventory
{
    internal class Item : MonoBehaviour
    {
#region ||~~~~~~~~|| SERIALIZE FIELDS  ||~~~~~~~~||

        [Header("Item Properties")]


        [Tooltip("Item 3D model")]
        [SerializeField] private GameObject itemModel;


        [Tooltip("Item 2D Design")]
        [SerializeField] private Sprite itemSprite;
        [SerializeField] private Sprite itemVisible;

        [SerializeField] private string itemName;
        [SerializeField] private string itemDescription;
        [SerializeField] private bool canAddToInventory = true;
        [SerializeField] private bool canMove = false;


        [SerializeField] private GameObject itemAbleToGameObject;

        [SerializeField] private ItemType itemType;

        [SerializeField] private bool cableIsTrue = false;

#endregion ||~~~~~~~~|| XXXX ||~~~~~~~~||




        public enum ItemType
        {
            paper,
            cable,
            key
        }





#region ||~~~~~~~~|| PROPERTIES ||~~~~~~~~||

        internal GameObject _itemModel { get => this.itemModel; }
        internal Sprite _itemSprite { get => this.itemSprite; }
        internal string _itemName { get => this.itemName; }
        internal string _itemDescription { get => this.itemDescription; }
        internal bool _canAddToInventory { get => this.canAddToInventory; }
        internal bool _canMove { get => this.canMove; }
        internal GameObject _itemAbleToGameObject { get => this.itemAbleToGameObject; }
        internal ItemType _itemType { get => this.itemType; }
        internal bool _cableIsTrue { get => this.cableIsTrue; }
        internal Sprite _itemVisible { get => this.itemVisible; }

#endregion ||~~~~~~~~|| XXXX ||~~~~~~~~||
    }
}