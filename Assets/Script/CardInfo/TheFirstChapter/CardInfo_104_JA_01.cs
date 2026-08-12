using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_01 : CardInfo
{
    public CardInfo_104_JA_01()
    {
        this.cardNo = "104_JA_01";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ƒAƒ‰ƒWƒ“";
        this.cardName2 = "–³–@‚Ì‰p—Y";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Nicholas Kole";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
