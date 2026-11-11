using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_05 : CardInfo
{
    public CardInfo_013_JA_05()
    {
        this.cardNo = "013_JA_05";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "クリストフ";
        this.cardName2 = "トナカイ飼い";
        this.power = 3;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
