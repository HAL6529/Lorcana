using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_12 : CardInfo
{
    public CardInfo_196_JA_12()
    {
        this.cardNo = "196_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "石使いの召使い";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandyLee;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
