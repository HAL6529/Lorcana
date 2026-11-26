using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_14 : CardInfo
{
    public CardInfo_108_JA_14()
    {
        this.cardNo = "108_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "アビゲイル・キャラハン";
        this.cardName2 = "経験豊富なテストパイロット";
        this.power = 7;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IsabellaCaravoloAndPalomaSauvage;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
