using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_09 : CardInfo
{
    public CardInfo_095_JA_09()
    {
        this.cardNo = "035_JA_09";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ジャスミン";
        this.cardName2 = "恐れ知らずの王女";
        this.power = 3;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
