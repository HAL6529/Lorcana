using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_08 : CardInfo
{
    public CardInfo_022_JA_08()
    {
        this.cardNo = "022_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "トランプ";
        this.cardName2 = "ちょいワル犬";
        this.power = 2;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ErikaWiseman;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
