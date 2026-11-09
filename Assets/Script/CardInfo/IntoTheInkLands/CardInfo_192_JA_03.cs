using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_03 : CardInfo
{
    public CardInfo_192_JA_03()
    {
        this.cardNo = "192_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ÉVÉìÉo";
        this.cardName2 = "êÌÇ§â§éq";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
