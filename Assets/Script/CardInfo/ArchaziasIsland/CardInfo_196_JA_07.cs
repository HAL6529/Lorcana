using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_07 : CardInfo
{
    public CardInfo_196_JA_07()
    {
        this.cardNo = "196_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒ€ƒtƒ@ƒT";
        this.cardName2 = "‘¸Œh‚³‚ê‚é‰¤";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmandaMacFarlane;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
