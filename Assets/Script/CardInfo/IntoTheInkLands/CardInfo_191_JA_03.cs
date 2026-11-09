using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_03 : CardInfo
{
    public CardInfo_191_JA_03()
    {
        this.cardNo = "191_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ノッティンガムのシェリフ";
        this.cardName2 = "汚職代官";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
