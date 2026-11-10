using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_03 : CardInfo
{
    public CardInfo_186_JA_03()
    {
        this.cardNo = "186_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒiƒ‰";
        this.cardName2 = "àÖ–Ò‚È—c‚È‚¶‚Ý";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
