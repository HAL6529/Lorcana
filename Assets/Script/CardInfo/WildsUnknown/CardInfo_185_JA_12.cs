using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_12 : CardInfo
{
    public CardInfo_185_JA_12()
    {
        this.cardNo = "185_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "Mr.インクレディブル";
        this.cardName2 = "粗大ゴミを片付けるぞ！";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
