using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_207_JA_08 : CardInfo
{
    public CardInfo_207_JA_08()
    {
        this.cardNo = "207_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "パディータ";
        this.cardName2 = "決意の母犬";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NatalieDombois;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
