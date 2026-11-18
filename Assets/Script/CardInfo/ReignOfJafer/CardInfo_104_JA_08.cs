using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_08 : CardInfo
{
    public CardInfo_104_JA_08()
    {
        this.cardNo = "104_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "アリス";
        this.cardName2 = "ぶきっちょなドジっ子";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AriannaRea;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
