using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_11 : CardInfo
{
    public CardInfo_174_JA_11()
    {
        this.cardNo = "174_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ダークウィング・ダック";
        this.cardName2 = "この世の悪と闘う男";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SergioMancinelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
