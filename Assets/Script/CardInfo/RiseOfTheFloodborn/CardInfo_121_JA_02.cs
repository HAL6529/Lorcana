using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_02 : CardInfo
{
    public CardInfo_121_JA_02()
    {
        this.cardNo = "121_JA_02";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ラティガン";
        this.cardName2 = "とてもでっかいネズミ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
