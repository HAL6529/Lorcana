using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_03 : CardInfo
{
    public CardInfo_035_JA_03()
    {
        this.cardNo = "035_JA_03";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉAÉäÉX";
        this.cardName2 = "Ç®íÉâÔÇÃòBã‡èpét";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NicolaSavioriAndRaquelVillanueva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
