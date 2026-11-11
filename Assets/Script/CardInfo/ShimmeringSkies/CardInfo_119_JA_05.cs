using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_05 : CardInfo
{
    public CardInfo_119_JA_05()
    {
        this.cardNo = "119_JA_05";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "ガストン";
        this.cardName2 = "完璧なヒーロー";
        this.power = 10;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DaveAlvarezAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
