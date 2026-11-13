using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_07 : CardInfo
{
    public CardInfo_157_JA_07()
    {
        this.cardNo = "157_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ƒ_ƒ‹ƒN";
        this.cardName2 = "”Ú—ò‚Èˆ«“¿ˆãŽt";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
