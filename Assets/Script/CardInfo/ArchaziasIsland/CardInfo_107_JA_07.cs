using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_07 : CardInfo
{
    public CardInfo_107_JA_07()
    {
        this.cardNo = "107_JA_07";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ミスター・スミー";
        this.cardName2 = "テキパキ船長";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
