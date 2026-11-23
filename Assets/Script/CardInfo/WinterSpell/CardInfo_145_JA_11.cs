using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_11 : CardInfo
{
    public CardInfo_145_JA_11()
    {
        this.cardNo = "145_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ダークウィング・ダック";
        this.cardName2 = "ドレイク・マラード";
        this.power = 4;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SerenaWade;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
