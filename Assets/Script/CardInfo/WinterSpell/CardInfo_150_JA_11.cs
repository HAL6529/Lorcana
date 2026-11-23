using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_11 : CardInfo
{
    public CardInfo_150_JA_11()
    {
        this.cardNo = "150_JA_11";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ダークウィング・ダック";
        this.cardName2 = "華麗なるガジェットマスター";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
