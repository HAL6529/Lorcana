using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_05 : CardInfo
{
    public CardInfo_018_JA_05()
    {
        this.cardNo = "018_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ƒ‚ƒAƒi";
        this.cardName2 = "‰ÊŠ¸‚È’TŒŸ‰Æ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsabellaCeravolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
