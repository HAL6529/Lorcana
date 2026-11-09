using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_208_JA_03 : CardInfo
{
    public CardInfo_208_JA_03()
    {
        this.cardNo = "208_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "ド派手な幻術使い";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
