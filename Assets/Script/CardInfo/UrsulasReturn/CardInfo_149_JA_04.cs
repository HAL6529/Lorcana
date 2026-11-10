using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_04 : CardInfo
{
    public CardInfo_149_JA_04()
    {
        this.cardNo = "149_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "オラフ";
        this.cardName2 = "ニンジン愛好家";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaurenLevering;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.ShiftDiscardAnActionCard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
