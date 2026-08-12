using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_01 : CardInfo
{
    public CardInfo_109_JA_01()
    {
        this.cardNo = "109_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "エルサ";
        this.cardName2 = "アイスサーファー";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Alice Pisoni / Whitney Pollett";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
