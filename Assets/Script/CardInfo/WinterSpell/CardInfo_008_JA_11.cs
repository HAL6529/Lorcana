using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_11 : CardInfo
{
    public CardInfo_008_JA_11()
    {
        this.cardNo = "008_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ポカホンタス";
        this.cardName2 = "道を探す者";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TaniaSoler;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
