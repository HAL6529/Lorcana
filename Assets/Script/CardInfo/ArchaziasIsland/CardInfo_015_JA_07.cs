using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_07 : CardInfo
{
    public CardInfo_015_JA_07()
    {
        this.cardNo = "015_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒVƒ“ƒfƒŒƒ‰";
        this.cardName2 = "‚Ò‚Á‚½‚è‚Ì‘«‚ğ‚Â–º";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.TaniaSoler;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
