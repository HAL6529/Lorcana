using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_027_JA_11 : CardInfo
{
    public CardInfo_027_JA_11()
    {
        this.cardNo = "027_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "パーシー";
        this.cardName2 = "つめたイヌ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JosepSole;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
