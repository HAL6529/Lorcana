using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_226_JA_03 : CardInfo
{
    public CardInfo_226_JA_03()
    {
        this.cardNo = "226_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ホーンド・キング";
        this.cardName2 = "邪悪な魔王";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlbertoDalLago;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
