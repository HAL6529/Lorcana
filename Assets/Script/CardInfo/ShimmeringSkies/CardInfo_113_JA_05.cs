using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_05 : CardInfo
{
    public CardInfo_113_JA_05()
    {
        this.cardNo = "113_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒ‰ƒeƒBƒKƒ“";
        this.cardName2 = "ƒV‚·‚ικ–•—ή";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AdamFenton;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
