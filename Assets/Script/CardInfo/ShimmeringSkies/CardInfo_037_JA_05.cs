using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_05 : CardInfo
{
    public CardInfo_037_JA_05()
    {
        this.cardNo = "037_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "コグスワース";
        this.cardName2 = "イルミナの警備次官";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
