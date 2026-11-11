using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_05 : CardInfo
{
    public CardInfo_092_JA_05()
    {
        this.cardNo = "092_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "マザー・ゴーテル";
        this.cardName2 = "揺るぎない策謀家";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DylanBonner;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
